import { useEffect, useState } from "react";
import { IProduct } from "../product/Interface";
import './Home.css'
import instance from "../../services/Api";
import NavDropdown from "react-bootstrap/esm/NavDropdown";
import { Link } from "react-router-dom";

export default function Product(){
    // const [products, setProducts] = useState<IProduct[]>([
    //     {id: 1, name: "Produto 1", description: "descrição 1", color: "azul", category: "Categoria 1", imageURL:"https://http2.mlstatic.com/D_NQ_NP_2X_829680-MLB47479260290_092021-F.webp", price: 100},
    //     {id: 2, name: "Produto 2", description: "descrição 2", color: "rosa", category: "Categoria 2", imageURL:"B", price: 200},
    //     {id: 3, name: "Produto 3", description: "descrição 3", color: "amarelo", category: "Categoria 3", imageURL:"C", price: 300},
    // ])

    const [products, setProducts] = useState<IProduct[]>([]);

    async function loadAllProducts(){
        const token = localStorage.getItem('token')
        const allProducts = await instance.get<IProduct[]>(
            "/api/Product/GetAllProducts"
            ,
            {
                headers: { Authorization: `Bearer ${token}` }
            }
            
        )

        // setAllProducts(allProducts.data)
        return allProducts.data
    }

    useEffect(() => {
        const getAllProducts = async () => {
          const products = await loadAllProducts();
          setProducts(products)
        //   setExams(respExams);
        //   setIsLoaded(true);
        //   setCounter(counter);
        //   console.log(respExams);
        }
        getAllProducts();
    }, []);

    return(
        <div className="homeStyle">
            {/* <button onClick={LoadAllProducts}>Oi</button> */}
            <div className="productsListHome">
                {
                    products.map(product => {
                        return(
                        <div className="productContainer" key={product.productName + product.productImageURL}>
                            <img className="img" src={product.productImageURL}></img><hr></hr>
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
                    })
                }
                
            </div>
        </div>
        )
}