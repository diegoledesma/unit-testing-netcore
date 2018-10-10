import React from 'react'
import {shallow} from 'enzyme'
import AlbumList from './AlbumList'

it('should render an album for each element', () => {
    const fakeList = [
        {
            title: 'a-1',
            coverHttpPath: 'c-1'
        },
        {
            title: 'b-1',
            coverHttpPath: 'd-1'
        }
    ]

    const inputProps = {
        albums: fakeList
    }

    const container = shallow(<AlbumList {...inputProps}></AlbumList>)
    const albumElements = container.children()
    expect(albumElements.length).toBe(2)
});




