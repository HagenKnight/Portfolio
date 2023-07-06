import React from 'react';
// import logo from './assets/img/main_photo.jpg';
import './assets/styles/reset.css'
import './assets/styles/bootstrap-grid.min.css'
import './assets/styles/animations.css'
import './assets/styles/perfect-scrollbar.css'
import './assets/styles/main.css'
import './assets/styles/owl.carousel.css'
import './assets/styles/magnific-popup.css'

import { Background } from './components/common/background';
import { ArrowsNav } from './components/common/arrowsNav';
import { HeaderCard } from './components/cards/headerCard';
// import { Preloader } from './components/loaders/preloaders';
import { MobileMenu } from './components/menu/mobileMenu';

function App() {
  return (
    <>
      <Background></Background>
      {/* <Preloader></Preloader> */}
      
      <div className="page">

        <div className="page-content">
          <HeaderCard></HeaderCard>
          <MobileMenu></MobileMenu>
          <ArrowsNav></ArrowsNav>

          <div className="content-area">

            <div className="animated-sections">
            </div>
          </div>

        </div>
      </div>
    </>
  );
}

export default App;
