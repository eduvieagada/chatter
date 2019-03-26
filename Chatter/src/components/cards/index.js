import React from 'react';
import './styles/cards.scss'
import img from './assets/610741220.0.jpg'

const Card = props => (

    <div className={"Card"}>
        <img src={props.item.ImageUrl} alt={"news-logo"}/>
        <div>
            <p className={"source"}>{props.item.SourceName}</p>
            <p>{props.item.Title}</p>
            <p className={"author"}>By <span className={"author-name"}>{props.item.Author}</span> | {new Date(props.item.DatePublished).toDateString()}</p>
        </div>

    </div>
);
export default Card;