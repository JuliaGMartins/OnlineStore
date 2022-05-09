import { useState } from "react";
import { IProduct } from "./Interface";
import './SearchProduct.css'
import instance from "../../services/Api";
import { Color } from "./ProductColor";
import { Category } from "./ProductCategory";
import { NavDropdown } from "react-bootstrap";
import { Link } from "react-router-dom";
import { FaSistrix } from 'react-icons/fa';
import { IoSearchCircle } from 'react-icons/io5';
import { VscError } from 'react-icons/vsc';

export default function Product(){
    // const [products, setProducts] = useState<IProduct[]>([
    //     {id: 1, name: "Produto 1", description: "descrição 1", color: "azul", category: "Categoria 1", imageURL:"https://http2.mlstatic.com/D_NQ_NP_2X_829680-MLB47479260290_092021-F.webp", price: 100},
    //     {id: 2, name: "Produto 2", description: "descrição 2", color: "rosa", category: "Categoria 2", imageURL:"B", price: 200},
    //     {id: 3, name: "Produto 3", description: "descrição 3", color: "amarelo", category: "Categoria 3", imageURL:"C", price: 300},
    // ])

    //Criar variável de estado
    const [products, setProducts] = useState<IProduct[]>([]);
    const [text, setText] = useState<string>("");
    const [productsLoaded, setProductsLoaded] = useState<boolean>(false);

    // function axiosTeste(){
    //     instance.get(
    //         "/api/Product/GetAllProducts"
    //     ).then(function(response){
    //         console.log(response);
    //     }).catch(function(error){
    //         console.log(error);
    //     });
    // }

    async function searchByColor(cor: Color){
        setProductsLoaded(false)
        const token = localStorage.getItem("token")
        const productsByColor =  await instance.get(
            "/api/Product/Color?color="+cor,
            { headers: { Authorization: `Bearer ${token}` } }
        )
            //Atribuir a variável de estado
        setProducts(productsByColor.data)
        setProductsLoaded(true)
    }

    async function searchByCategory(cat: Category){
        setProductsLoaded(false)
        const token = localStorage.getItem("token")
        const productsByCat =  await instance.get(
            "/api/Product/Category?cat="+cat,
            { headers: { Authorization: `Bearer ${token}` } }
        )
            //Atribuir a variável de estado
        setProducts(productsByCat.data)
        setProductsLoaded(true)
    }

    async function searchByName(name: string){
        setProductsLoaded(false)
        const token = localStorage.getItem("token")
        const productsByName =  await instance.get(
            "/api/Product/"+name,
            { headers: { Authorization: `Bearer ${token}` } }
        )
            //Atribuir a variável de estado
        setProducts(productsByName.data)
        setProductsLoaded(true)
    }

    const handleChange = e => {
        setText(e.target.value);
    }

    return(
        <div>
            <div className="searchContainer">
                <h1 className="title">Search by <IoSearchCircle className="icon"/></h1>
                <div className="row">
                <NavDropdown id='searchButtons' title="Name">
                    {
                        <div className="searchButtonContainer">
                            <input onChange={handleChange} value={text} type="text" ></input>
                            <button onClick={async () => await searchByName(text)} id='button'>Search</button>
                        </div>
                    }
                </NavDropdown>    
                
                <NavDropdown id='searchButtons' title="Color">
                    {
                        Object.keys(Color).filter(k => isNaN(Number(k))).map((color) => {
                            return(
                                <NavDropdown.Item id='buttonDrop' onClick={async () => console.log(await searchByColor(Color[color]))}>
                                    {color}
                                </NavDropdown.Item>
                            )
                        })
                    }
                </NavDropdown>
                <NavDropdown id='searchButtons' title="Category">
                    {
                        Object.keys(Category).filter(k => isNaN(Number(k))).map((cat) => {
                            return(
                                <NavDropdown.Item id='buttonDrop' onClick={async () => console.log(await searchByCategory(Category[cat]))}>
                                    {cat}
                                </NavDropdown.Item>
                            )
                        })
                    }
                </NavDropdown>
                </div>   
            </div> 
           
                <div className="productsList">
                    
                        {/* //trocar products por variável de estado */}
                        {productsLoaded && products.length == 0 
                            && <h1 className="productName"><VscError className="icon"/>No products were found</h1>}
                        {
                        productsLoaded && products.length >= 1 && 
                            products.map(product => {
                                return(
                                <div className="productContainer" key={product.productName + product.productImageURL}>
                                    <img className="img" src={product.productImageURL}></img>
                                    <div>
                                        <h1 className="productPrice">R$ {product.productPrice}</h1>
                                        <h1 className="productName">{product.productName}</h1>
                                        <NavDropdown id='button' title="See Description">
                                            <NavDropdown.Item id='buttonDrop' eventKey="1">
                                                <Link id='buttonDrop' to="/LoginPage">{product.productDescription}</Link>
                                            </NavDropdown.Item>
                                        </NavDropdown>
                                        <button id="addToCart">Add To Cart</button>
                                    </div>
                                </div>
                            ) 
                            }
                            )
                        }
                    
            </div>
        </div>
        )
}