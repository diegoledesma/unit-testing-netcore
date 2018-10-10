import React, { Component } from 'react'
import PropTypes from 'prop-types'
import Album from './Album'

class AlbumList extends Component {
    render() {
        return (<div>
            {
                this.props.albums.map(a => (
                <Album
                    title={a.title}
                    coverHttpPath={a.coverHttpPath}
                    key={a.coverHttpPath}>
                </Album>))
            }
        </div>)
    }
}

AlbumList.propTypes = {
    albums: PropTypes.arrayOf(PropTypes.object)
}

export default AlbumList