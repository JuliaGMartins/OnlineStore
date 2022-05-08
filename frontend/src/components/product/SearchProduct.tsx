import { useState } from "react";
import { IProduct } from "./Interface";
import './SearchProduct.css'
import instance from "../../services/Api";
import { Color } from "./ProductColor";
import { Category } from "./ProductCategory";
import { NavDropdown } from "react-bootstrap";
import { Link } from "react-router-dom";

export default function Product(){
    // const [products, setProducts] = useState<IProduct[]>([
    //     {id: 1, name: "Produto 1", description: "descrição 1", color: "azul", category: "Categoria 1", imageURL:"https://http2.mlstatic.com/D_NQ_NP_2X_829680-MLB47479260290_092021-F.webp", price: 100},
    //     {id: 2, name: "Produto 2", description: "descrição 2", color: "rosa", category: "Categoria 2", imageURL:"B", price: 200},
    //     {id: 3, name: "Produto 3", description: "descrição 3", color: "amarelo", category: "Categoria 3", imageURL:"C", price: 300},
    // ])

    //Criar variável de estado
    const [products, setProducts] = useState<IProduct[]>([]);
    const [text, setText] = useState<string>("");

    function axiosTeste(){
        instance.get(
            "/api/Product/GetAllProducts"
        ).then(function(response){
            console.log(response);
        }).catch(function(error){
            console.log(error);
        });
    }

    async function searchByColor(cor: Color){
        const productsByColor =  await instance.get(
            "/api/Product/Color?color="+cor
        )
            //Atribuir a variável de estado
        setProducts(productsByColor.data)
    }

    async function searchByCategory(cat: Category){
        const productsByCat =  await instance.get(
            "/api/Product/Category?cat="+cat
        )
            //Atribuir a variável de estado
        setProducts(productsByCat.data)
    }

    async function searchByName(name: string){
        const productsByName =  await instance.get(
            "/api/Product/"+name
        )
            //Atribuir a variável de estado
        setProducts(productsByName.data)
    }

    const handleChange = e => {
        setText(e.target.value);
    }

    return(
        <div>
            <div><h1 className="title">Search by: </h1>
                <div className="row">
                <NavDropdown id='searchButtons' title="Name">
                    {
                        <div>
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
                    {
                        //trocar products por variável de estado
                        products.map(product => {
                            return(
                            <div key={product.productName + product.productImageURL}>
                                <img className="img" src={product.productImageURL}></img>
                                <h1 className="product">{product.productName} <br></br>{product.productPrice} R$</h1>
                            </div>
                            ) 
                        })
                    }
            </div>
        </div>
        )
}