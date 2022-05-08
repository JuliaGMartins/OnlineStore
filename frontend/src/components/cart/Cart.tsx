import { useState } from "react";
import { IProduct } from "../product/Interface";
import './Cart.css'
import instance from "../../services/Api";

export default function Products(){
    const [products, setProducts] = useState<IProduct[]>([]);

    async function axiosTeste(){
        const products = await instance.get(
            "/api/Product/GetAllProducts"
        )
        setProducts(products.data)
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
                              <h1 className="productCart">{product.productName} {product.productImageURL} {product.productPrice} R$</h1>  
                        ) 
                    })
                }
                
            </div>
                <button onClick={axiosTeste}>Oi</button>
            </div>
        )
}