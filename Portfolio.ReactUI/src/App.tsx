import React, { useState, useEffect } from 'react';

// import logo from './assets/img/main_photo.jpg';
import 'react-perfect-scrollbar/dist/css/styles.css';
import './assets/styles/reset.css'
import './assets/styles/bootstrap-grid.min.css'
import './assets/styles/animations.css'
import './assets/styles/main.css'
import './assets/styles/owl.carousel.css'
import './assets/styles/magnific-popup.css'

import { Background } from './components/common/background';
import { ArrowsNav } from './components/common/arrowsNav';
import { HeaderCard } from './components/cards/headerCard';
import { Preloader } from './components/loaders/preloaders';
import { MobileMenu } from './components/menu/mobileMenu';
import { HomePage } from './pages/home';
import { AboutMePage } from './pages/aboutMe';
// import * as $ from 'jquery';

function App() {

  const [loading, setLoading] = useState(false);

  useEffect(() => {
    console.log("App useEffect");
    setLoading(true);
    setTimeout(() => {
      setLoading(false);
    }, 3000);


    // PerfectScrollbar Handler init

    // PerfectScrollbar Handler end

  }, []);

  return (
    <>

      {loading ?
        (<Preloader></Preloader>) :
        (null)
      }

      <Background></Background>

      <div className="page">

        <div className="page-content">
          <HeaderCard></HeaderCard>
          <MobileMenu></MobileMenu>
          <ArrowsNav></ArrowsNav>

          <div className="content-area">

            <div className="" >
              {/* <HomePage></HomePage> */}
              <AboutMePage></AboutMePage>

            </div>
          </div>

        </div>
      </div>
    </>
  );
}

export default App;
