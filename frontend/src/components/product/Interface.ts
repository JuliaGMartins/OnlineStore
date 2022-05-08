import { Color } from "./ProductColor";
import { Category } from "./ProductCategory";

export interface IProduct {
    productName: string,
    productDescription: string,
    color: Color,
    category: Category,
    productImageURL: string,
    productPrice: number,
}