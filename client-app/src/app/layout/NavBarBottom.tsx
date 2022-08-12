import { observer } from "mobx-react-lite";
import React from "react";
import { Container, Menu } from "semantic-ui-react";

export default observer (function NavBarBottom(){
    
    return(
        <Menu inverted>
            <Container>
                <Menu.Item name="Start Date" />
                <Menu.Item name="End Date" />
                <Menu.Item name="Filters" />
            </Container>
        </Menu>
    )
})