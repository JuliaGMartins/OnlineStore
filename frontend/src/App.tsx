import { useState } from 'react'
import './App.css'
import Login from './components/login/Login'
import ProductSearch from './pages/ProductSearch'

function App() {
  const [count, setCount] = useState(0)

  return (
    <div className="App">
      {/* <Login></Login> */}
      <ProductSearch></ProductSearch>
    </div>
  )
}

export default App
