import React from 'react';
import './styles/cards.scss'
import img from './assets/610741220.0.jpg'

const Card = props => (
    <div className={"card-parent"}>
    <div className={"Card"}>
        <img src={props.item.ImageUrl} alt={"news-logo"}/>
        <div>
            <p className={"source"}>{props.item.SourceName}</p>
            <p>{props.item.Title}</p>
            <p className={"author"}>By <span className={"author-name"}>{props.item.Author}</span> | {props.item.DatePublished}</p>
        </div>

    </div>
    </div>
);
export default Card;