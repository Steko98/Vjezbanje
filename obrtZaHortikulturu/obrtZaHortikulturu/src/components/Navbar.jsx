import React, { useState, useEffect } from 'react';
import Navbar from 'react-bootstrap/Navbar';
import Container from 'react-bootstrap/Container';
import { CiInstagram, CiFacebook } from "react-icons/ci";
import { Card, Col, Row } from 'react-bootstrap';
import CarouselCard from './CarouselCard'; // adjust path if needed

import './Navbar.css';

function FullScreenHero() {
  const [showNavbar, setShowNavbar] = useState(true);
  const [lastScrollY, setLastScrollY] = useState(0);

  useEffect(() => {
    const handleScroll = () => {
      if (window.scrollY > lastScrollY) {
        // scrolling down
        setShowNavbar(false);
      } else {
        // scrolling up
        setShowNavbar(true);
      }
      setLastScrollY(window.scrollY);
    };

    window.addEventListener('scroll', handleScroll);

    return () => window.removeEventListener('scroll', handleScroll);
  }, [lastScrollY]);

  return (
    <div className="hero-section">
      <div className={`navbar-wrapper ${showNavbar ? 'visible' : 'hidden'}`}>
        <Navbar expand="lg" className="hero-navbar fixed-top">
          <Container className="d-flex align-items-center">
            <div className="left-spacer" />
            <div className="center-brand d-flex justify-content-center flex-grow-1">
              <Navbar.Brand href="#" className="text-custom">
                Marek
                <p className='podnaslov'>OBRT ZA HORTIKULTURU</p>
              </Navbar.Brand>
            </div>
            <div className="right-icons d-flex justify-content-end gap-3 text-white align-items-center">
              <a href="https://facebook.com" target="_blank" rel="noopener noreferrer">
                <CiFacebook className='pulse-icon' size={35} />
              </a>
              <a href="https://instagram.com" target="_blank" rel="noopener noreferrer">
                <CiInstagram className='pulse-icon' size={35} />
              </a>
            </div>
          </Container>
        </Navbar>
      </div>
        <div className="hero-card-wrapper">
          <Container className="card-grid-container">
            <Row className="justify-content-center align-items-stretch" style={{ minHeight: '400px' }}>
              <Col xs={12} md={3} className="d-flex flex-column align-items-center justify-content-center gap-5">
                <Card className="small-card">O nama</Card>
                <Card className="small-card">Usluge</Card>
              </Col>

              <Col xs={12} md={6} className="d-flex align-items-center justify-content-center">
                <CarouselCard />
               </Col>

              <Col xs={12} md={3} className="d-flex flex-column align-items-center justify-content-center gap-5">
                <Card className="small-card">Kontakt</Card>
                <Card className="small-card">Small Card 4</Card>
              </Col>
            </Row>
          </Container>
        </div>
    </div>
  );
}

export default FullScreenHero;
