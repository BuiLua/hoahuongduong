import React, { Component, PropTypes } from 'react';

class ListItems extends Component {

    constructor(props) {
        super(props);

        this.state = {
        	listItems: ["Meo", "Cho", "Ga"],
        	isShow: true
        }

        this.handleSort = this.handleSort.bind(this)
        this.handleClickLi = this.handleClickLi.bind(this)
        this.handleToggle = this.handleToggle.bind(this)
    }

    handleSort() {
    	let {
    		listItems,
    	} = this.state

    	listItems.sort()

    	this.setState({
    		listItems
    	})
    }

    handleClickLi(item) {
    	alert("Ban vua click "+item)
    }

    handleToggle() {
    	let {
    		isShow
    	} = this.state

    	isShow = !isShow

    	this.setState({
    		isShow
    	})
    }

    render() {

    	let {
    		listItems,
    		isShow
    	} = this.state

  		//let divItems = listItems.map(( 
		// 	function(item) {
		// 		return (
		// 			<li onClick={this.handleClickLi.bind(this, item)}>{item}</li>
		// 		)
		// 	} 
		// ).bind(this))
		
		let that = this
		let divItems = listItems.map(
			function(item) {
				return (
					<li onClick={that.handleClickLi.bind(that, item)}>{item}</li>
				)
			})
        return (
            
            <div>
				<button onClick={this.handleToggle}>Toggle</button>
            	{
            		isShow ?
	            	(
	            		<div>
	            			<button onClick={this.handleSort}>Sort list items</button>
	            			<ul>
	            				{divItems}
	            			</ul>
	            		</div>
	            	) : null
            	}

            </div>
        );
    }
}

export default ListItems;
