import { useState } from "react";
import { IProduct } from "./Interface";
import './Products.css'
import instance from "../../services/Api";

export default function Products(){
    const [products, setProducts] = useState<IProduct[]>([
        {id: 1, name: "Produto 1", description: "descrição 1", color: "azul", category: "Categoria 1", imageURL:"", price: 100},
        {id: 2, name: "Produto 2", description: "descrição 2", color: "rosa", category: "Categoria 2", imageURL:"", price: 200},
        {id: 3, name: "Produto 3", description: "descrição 3", color: "amarelo", category: "Categoria 3", imageURL:"", price: 300},
    ])

    function axiosTeste(){
        instance.get(
            "/api/Product/GetAllProducts"
        ).then(function(response){
            console.log(response);
        }).catch(function(error){
            console.log(error);
        });
    }

    return(
            <div className="productsList">
                {
                    products.map(product => {
                        return(
                            <h1 className="product">{product.name} - {product.price} R$</h1>
                        ) 
                    })
                }
                <button onClick={axiosTeste}>Oi</button>
            </div>
        )
}