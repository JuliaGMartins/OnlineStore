import React from 'react'
import ReactDOM from 'react-dom/client'
import { BrowserRouter, Route, Routes } from 'react-router-dom'
import App from './App'
import CartPage from './pages/CartPage'
import HomePage from './pages/HomePage'
import LoginPage from './pages/LoginPage'
import ProductSearchPage from './pages/ProductSearchPage'
import './App.css'

ReactDOM.createRoot(document.getElementById('root')!).render(
  <div className="root">
  <React.StrictMode>
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<App/>}></Route>
        <Route path="/ProductSearchPage" element={<ProductSearchPage/>}></Route>
        <Route path="/HomePage" element={<HomePage></HomePage>}></Route>
        <Route path="/LoginPage" element={<LoginPage></LoginPage>}></Route>
        <Route path="/CartPage" element={<CartPage></CartPage>}></Route>
      </Routes>
    </BrowserRouter>
  </React.StrictMode>
  </div>
)
