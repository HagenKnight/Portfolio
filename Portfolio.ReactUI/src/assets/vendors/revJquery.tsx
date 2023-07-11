import React, { Component } from "react";

import $ from 'jquery';

export class revJquery extends Component {

    componentDidMount() {
        $("button").click(function () {
            $("h1").toggleClass("red");
        });
    }

    render() {
        return (
            <div className="App">
                <h1>jquery in React App</h1>
                <button>Click Me</button>
            </div>
        );
    }
};