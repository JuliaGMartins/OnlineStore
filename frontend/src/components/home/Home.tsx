import { useState } from "react";
import { IProduct } from "../product/Interface";
import './Home.css'
import instance from "../../services/Api";

export default function Product(){
    // const [products, setProducts] = useState<IProduct[]>([
    //     {id: 1, name: "Produto 1", description: "descrição 1", color: "azul", category: "Categoria 1", imageURL:"https://http2.mlstatic.com/D_NQ_NP_2X_829680-MLB47479260290_092021-F.webp", price: 100},
    //     {id: 2, name: "Produto 2", description: "descrição 2", color: "rosa", category: "Categoria 2", imageURL:"B", price: 200},
    //     {id: 3, name: "Produto 3", description: "descrição 3", color: "amarelo", category: "Categoria 3", imageURL:"C", price: 300},
    // ])

    const [products, getAllProducts] = useState<IProduct[]>([]);

    async function axiosTeste(){
        const allProducts = await instance.get(
            "/api/Product/GetAllProducts" 
        )

        getAllProducts(allProducts.data)
    }

    return(
        <div className="homeStyle">
            <button onClick={axiosTeste}>Oi</button>
            <div className="productsListHome">
                {
                    products.map(product => {
                        return(
                        <div key={product.productName + product.productImageURL}>
                            <img className="img" src={product.productImageURL}></img>
                            <h1 className="productHome">{product.productName} {product.productPrice}</h1>
                        </div>
                               
                        ) 
                    })
                }
                
            </div>
        </div>
        )
}