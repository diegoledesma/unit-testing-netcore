import React, { Component } from 'react'
import PropTypes from 'prop-types'

class Album extends Component {
    render(){
        return (
        <div style={{border:"1px solid", display:"flex", flexDirection:"column"}}>
            <span>{this.props.title}</span>
            <img src={this.props.coverHttpPath} alt="cover"/>
        </div>)
    }

}

Album.propTypes = {
    title: PropTypes.string,
    coverHttpPath: PropTypes.string
}

export default Album

