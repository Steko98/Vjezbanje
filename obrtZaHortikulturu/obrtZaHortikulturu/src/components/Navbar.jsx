import Container from 'react-bootstrap/Container';
import Navbar from 'react-bootstrap/Navbar';
import './Navbar.css';

function ContainerOutsideExample() {
  return (
    <Container>
      <Navbar bg="dark" variant="dark" expand="lg">
        <Container>
          <Navbar.Brand href="#" className="center-brand">Hortikultura Marek</Navbar.Brand>
        </Container>
      </Navbar>
    </Container>
  );
}

export default ContainerOutsideExample;