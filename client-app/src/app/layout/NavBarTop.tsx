import { observer } from "mobx-react-lite";
import React from "react";
import { NavLink } from "react-router-dom";
import { Container, Dropdown, Image, Menu } from "semantic-ui-react";

export default observer (function NavBarTop() {
    
    
    return (
        <Menu inverted >
            <Container>
                <Menu.Item as={NavLink} to='/' exact header>
                    <img src="/assets/logo.png" alt="logo" style={{marginRight: '10px'}} />
                </Menu.Item>
                <Menu.Item position="right">
                    <Image src={'/assets/user.png'} avatar spaced="right" />
                    <Dropdown pointing='top left' text="User">
                        <Dropdown.Menu>
                            <Dropdown.Item
                                text='My Profile'
                                icon='user'
                            />
                            <Dropdown.Item
                                text='Logout'
                                icon='power'
                            />
                        </Dropdown.Menu>
                    </Dropdown>

                </Menu.Item>
            </Container>
        </Menu>
    )
})