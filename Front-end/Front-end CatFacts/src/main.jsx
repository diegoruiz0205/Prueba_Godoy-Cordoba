import ReactDOM from 'react-dom/client'
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import App from './App';
import { Historial } from './Historial';
import { Fact } from './Fact';

ReactDOM.createRoot(document.getElementById('root')).render(
  <BrowserRouter>
    <Routes>
      <Route path="/" element={<App />}>
        <Route path="/historial" element={<Historial />} />
        <Route path="/fact" element={<Fact/>} />
      </Route>
      <Route path="*" element={<h1>Error de pagina.</h1>} />
    </Routes>
  </BrowserRouter>
);

// select * from xatributo_hplc;
// select * from xhpl_temp; 