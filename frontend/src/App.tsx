import { useState } from 'react'
import './App.css'
import Login from './components/login/Login'
import CartPage from './pages/CartPage'
import ProductSearchPage from './pages/ProductSearchPage'

function App() {
  const [count, setCount] = useState(0)

  return (
    <div className="App">
      {/* <CartPage></CartPage>
      <Login></Login> */}
      <ProductSearchPage></ProductSearchPage>
    </div>
  )
}

// return (      
//   <BrowserRouter>
//    <div>
//      <Navigation />
//        <Switch>
//         <Route path="/" component={ProductSearchPage} exact/>
//         <Route path="/login" component={LoginPage}/>
//         <Route path="/cart" component={CartPage}/>
//        <Route component={Error}/>
//       </Switch>
//    </div> 
//  </BrowserRouter>
// );
// }

export default App
