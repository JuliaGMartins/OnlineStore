import React from 'react'
import ReactDOM from 'react-dom/client'
import { BrowserRouter, Route, Routes } from 'react-router-dom'
import App from './App'
import CartPage from './pages/CartPage'
import HomePage from './pages/HomePage'
import LoginPage from './pages/LoginPage'
import ProductSearchPage from './pages/ProductSearchPage'
import './App.css'
import OrderPage from './pages/OrderPage'
import RegisterPage from './pages/RegisterPage'

ReactDOM.createRoot(document.getElementById('root')!).render(
  <div className="App">
  <React.StrictMode>
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<App/>}></Route>
        <Route path="/ProductSearchPage" element={<ProductSearchPage/>}></Route>
        <Route path="/HomePage" element={<HomePage></HomePage>}></Route>
        <Route path="/LoginPage" element={<LoginPage></LoginPage>}></Route>
        <Route path="/RegisterPage" element={<RegisterPage></RegisterPage>}></Route>
        <Route path="/CartPage" element={<CartPage></CartPage>}></Route>
        <Route path="/OrderPage" element={<OrderPage></OrderPage>}></Route>
      </Routes>
    </BrowserRouter>
  </React.StrictMode>
  </div>
)
