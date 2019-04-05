import React, { Component, PropTypes } from 'react';

class ImageText extends Component {

    constructor(props) {
        super(props);

        this.state = {
        	inputValue: this.props.initInputValue
        }

        this.updateInputValue = this.updateInputValue.bind(this)
    }

    updateInputValue(event){
	    let {
	      inputValue
	    } = this.state

	    inputValue = event.target.value

	    this.setState({
	      inputValue
	    })

	    let {
        	onInputChange
        } = this.props

        if(onInputChange) {
        	onInputChange(inputValue)
        }
  	}



    render() {

    	let {
    		clickOnApp
    	} = this.props

    	let {
    		inputValue
    	} = this.state

        return (

            <div>
            	<p>Click On App: {clickOnApp}</p>
	            <div>
                	<input value={inputValue} onChange={this.updateInputValue}/>
                </div>
                <p>{inputValue}</p>
            </div>
        );
    }
}

export default ImageText;
