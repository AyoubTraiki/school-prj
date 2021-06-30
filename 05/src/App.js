import { Component } from 'react';
import './App.css';
import  Letudiant   from './component/Letudiant'


class App extends Component{
  state={
    title:"Liste des etudiants"
  }
  modifytitle = (a) => {
    this.setState(
      {
        title : "Nouveau titre"
      }
    )
  }
  render(){
    return (
      <div className="App">
        <Letudiant title={this.state.title}/>
        <button className="change" onClick={this.modifytitle}>Modify title</button>
          
      </div>
    )
  }




}

export default App;
