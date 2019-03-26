import React, {Component, Fragment} from 'react';
import Navigation from './components/navigation';
import Jumbo from "./components/jumbo";
import Card from "./components/cards";

class App extends Component {
    state = {
        news: [
            {
                "SourceName": "",
                "Author": "",
                "Title": "",
                "Description": "",
                "Url": "",
                "ImageUrl": "",
                "DatePublished": ""
            }
        ]
    };

    componentDidMount() {
        fetch("http://localhost:51563/api/news")
            .then(response => response.json())
            .then(json => this.setState({ news: json }));
    };

    render() {

        return (
            <Fragment>
                <Navigation/>
                <Jumbo news={this.state.news[0]}/>
                {
                    this.state.news.slice(1).map(item => (
                        <Card key={item.index} item={item}/>
                    ))
                }
            </Fragment>
        );
    }
}

export default App;
