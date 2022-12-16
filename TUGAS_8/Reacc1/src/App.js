import "./assets/App.css"
import { BrowserRouter as Router, Routes, Route, Link } from "react-router-dom"
import Account from "./components/Account"
import Blog from "./components/Blog"
import User from "./components/User"
import logo from "./assets/logo-unri.png"

function App() {
  return (
    <div className="center">
    <Router>
      <div>
        <Link to="/"> Home </Link> |
        <Link to="/account"> Account </Link> |
        <Link to="/blog"> Blog </Link>
      </div>
      <img src={logo} className="App-logo" /> 
      <Routes>
        <Route exact path="/" element={<User />} />
        <Route path="/account" element={<Account />} />
        <Route path="/blog" element={<Blog />} />
      </Routes>
    </Router>
    </div>
  );
}

export default App