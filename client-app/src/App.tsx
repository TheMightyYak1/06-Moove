import React from 'react';
import './App.css';
import { Route, Switch } from 'react-router-dom';
import NavBarTop from './app/layout/NavBarTop';
import { Container, Grid } from 'semantic-ui-react';
import NavBarBottom from './app/layout/NavBarBottom';

function App() {
  return (
    <>

      <Route
        path={'/'}
        render={() => (
          <>
          <Grid>
            <Grid.Row>
              <Grid.Column>
                <NavBarTop />
              </Grid.Column>  
            </Grid.Row>
            <Grid.Row>
              <Grid.Column>
                <NavBarBottom />
              </Grid.Column>
            </Grid.Row>
          </Grid>
            <Container style={{marginTop: '7em'}}>
              <Switch>

              </Switch>
            </Container>
          </>
        )}
      />
    </>
  );
}

export default App;
