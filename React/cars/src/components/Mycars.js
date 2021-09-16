import React, { Component } from 'react';
import Car from './Cars';

class Mycars extends Component {

    noCopy = () => {
        alert('merci de n epas copier le text');
    }

    
    render() {
        return (

            <div>
                <h1>{this.props.title}</h1>
                <p onCopy={this.noCopy}>Lorem ipsum dolor sit amet consectetur, </p>

                <Car color="red">Ford</Car>
                <Car>Mercedes</Car>
                <Car color="green"></Car>
            </div>
        )

    }
}

export default Mycars;