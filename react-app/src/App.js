import './App.css'

import React, { Component } from 'react'
import AlbumList from './AlbumList'


class App extends Component {
  render() {
    return (
      <div className="App">
        <header className="App-header">
          <AlbumList albums={albumList}></AlbumList>
        </header>
      </div>
    )
  }
}

var albumList = [
  {
     "title":"Hughes / Thrall",
     "coverHttpPath":"https://img.discogs.com/iNbhVbA4VqFkBgWmsvf1GfHnyfY=/fit-in/300x300/filters:strip_icc():format(jpeg):mode_rgb():quality(40)/discogs-images/R-3151392-1445932154-9526.jpeg.jpg"
  },
  {
     "title":"Rattle And Hum Vol.1",
     "coverHttpPath":"https://img.discogs.com/0Zxh5HAFinsbLCM3msCn_7wKrLA=/fit-in/300x300/filters:strip_icc():format(jpeg):mode_rgb():quality(40)/discogs-images/R-12638188-1539100768-5354.jpeg.jpg"
  },
  {
     "title":"Shivers",
     "coverHttpPath":"https://img.discogs.com/c9iKVGEhxA-wimvYqPzDweC8bIM=/fit-in/300x300/filters:strip_icc():format(jpeg):mode_rgb():quality(40)/discogs-images/R-12638152-1539099990-2223.jpeg.jpg"
  },
  {
     "title":"Zombie",
     "coverHttpPath":"https://img.discogs.com/oJmbBENnpzf3cJcOOlA1JcUncjM=/fit-in/300x300/filters:strip_icc():format(jpeg):mode_rgb():quality(40)/discogs-images/R-1888854-1250324114.jpeg.jpg"
  }
]

export default App
