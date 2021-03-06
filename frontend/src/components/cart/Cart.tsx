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
        <div className="container">
            <div>
                {
                    products.map(product => {
                        return(
                              <h1 className="productCart">{product.productName} {product.productImageURL} {product.productPrice} R$</h1>  
                        ) 
                    })
                }
                
            </div>
            <div className="row">
                <button className="buyButton">Place Order</button>
                <button className="cancelButton">Cancel</button>
            </div>
        </div>
        )
}