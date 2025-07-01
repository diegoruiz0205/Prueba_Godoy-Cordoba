import Content from './Template/Content';
import Footer from './Template/Footer';
import Navbar from './Template/Navbar';
import Sidebar from './Template/Sidebar';

// Estidos css
import './assets/css/bootstrap.min.css';
import './assets/css/kaiadmin.min.css';

function App() {

  return (
    <>
      <div className="wrapper">

        {/* <!-- Sidebar --> */}
        <Sidebar />
        {/* <!-- End Sidebar --> */}

        <div className="main-panel">

          {/* Navbar */}
          <Navbar />
          {/* End Nabvar */}

          {/* Content */}
          <Content />
          {/* End Content */}

          {/* Footer */}
          <Footer />
          {/* End Footer */}

        </div>

      </div>
    </>
  );
};

// Archivos Js
import './assets/js/core/jquery-3.7.1.min.js';
import './assets/js/core/popper.min.js';
import './assets/js/core/bootstrap.min.js';

import './assets/js/plugin/jquery-scrollbar/jquery.scrollbar.js';
import './assets/js/kaiadmin.min.js';
import './assets/js/setting-demo.js';

export default App
