import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';
import ImageText from './imageText'
import ListItems from './listItems'

class App extends Component {

  constructor(props) {
    super(props)

    this.handleInputChange = this.handleInputChange.bind(this)
    this.handleClickOnApp = this.handleClickOnApp.bind(this)

    this.state = {
      countClick: 0,
      inputValue: 'Lua'
    }
  }

  handleClickOnApp(){
    let {
      countClick
    } = this.state

    countClick++

    this.setState({
      countClick
    })
  }

  handleInputChange(value){
    let {
      inputValue
    } = this.state

    inputValue = value

    this.setState({
      inputValue
    })
  }


  render() {
    
    let {
      countClick,
      inputValue
    } = this.state

    return (
      <div className="App" onClick={this.handleClickOnApp}>
        <p>
            Click On App: {countClick}
        </p>
        <p>
            {inputValue}
        </p>

        <hr/>

        <ImageText 
            clickOnApp={countClick}
            onInputChange={this.handleInputChange}
            initInputValue={inputValue}/>

        <hr/>

        <ListItems/>
        
      </div>
    );
  }
}

export default App;
