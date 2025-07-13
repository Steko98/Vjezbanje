
import { Card, Carousel, Button } from 'react-bootstrap';
import './CarouselCard.css';

function CarouselCard() {
  return (
    <Card className="large-card">
      <div className="carousel-wrapper">
        <Carousel fade interval={5000} controls indicators>
          <Carousel.Item>
            <img
              className="carousel-img"
              src="/slika1.jpg"
              alt="First slide"
            />
          </Carousel.Item>
          <Carousel.Item>
            <img
              className="carousel-img"
              src="/slika2.jpg"
              alt="Second slide"
            />
          </Carousel.Item>
          <Carousel.Item>
            <img
              className="carousel-img"
              src="/slika3.jpg"
              alt="Third slide"
            />
          </Carousel.Item>
        </Carousel>
      </div>

      <Card.Body className="text-center">
        <Card.Title className='cardNaslovi'>Galerija</Card.Title>
        <Button className='custom-btn'>Pogledaj više</Button>
      </Card.Body>
    </Card>
  );
}

export default CarouselCard;

