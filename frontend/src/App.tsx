import { useState } from 'react'
import './App.css'
import HomePage from './pages/HomePage'
import LoginPage from './components/login/Login'
import CartPage from './pages/CartPage'
import ProductSearchPage from './pages/ProductSearchPage'

function App() {

  return (
    <div className="App">
      <HomePage></HomePage>
    </div>
  )
}

export default App
