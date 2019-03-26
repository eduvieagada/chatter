import React, {Fragment} from 'react';
import './styles/jumbo.scss'
import img from './assets/image.jpg';

const Jumbo = props => (
    <Fragment>
        <div className={"jumbo"}>
            <div className={"gradient"}>
                <p className={"caption"}>{props.news.Title}</p>
                <span className={"span1"}>{props.news.Author} | {props.news.DatePublished}</span>
            </div>
            <img src={props.news.ImageUrl} alt={"jumbo"}/>
        </div>

    </Fragment>

);

export default Jumbo;