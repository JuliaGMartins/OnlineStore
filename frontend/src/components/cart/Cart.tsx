import { useState } from "react";
import { IProduct } from "../product/Interface";
import './Cart.css'
import instance from "../../services/Api";

export default function Products(){
    const [products, setProducts] = useState<IProduct[]>([
        {id: 1, name: "Produto 1", description: "descrição 1", color: "azul", category: "Categoria 1", imageURL:"A", price: 100},
        {id: 2, name: "Produto 2", description: "descrição 2", color: "rosa", category: "Categoria 2", imageURL:"B", price: 200},
        {id: 3, name: "Produto 3", description: "descrição 3", color: "amarelo", category: "Categoria 3", imageURL:"C", price: 300},
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
        <div>
            <h1>Product name</h1>
            <h1>Product price</h1>
            <h1>Product name</h1>
            <div className="productsListCart">
                {
                    products.map(product => {
                        return(
                              <h1 className="productCart">{product.name} {product.imageURL} {product.price} R$</h1>  
                        ) 
                    })
                }
                
            </div>
                <button onClick={axiosTeste}>Oi</button>
            </div>
        )
}