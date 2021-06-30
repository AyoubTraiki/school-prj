import React from 'react'
import {Component } from 'react'
import  Etudiant  from './Etudiant'


class Letudiant extends Component{
    
    render(){return(
            
        <div>
                
                <h1>{this.props.title}</h1>
                <Etudiant nom="Test1" prenom="xxx" filiere="ok"/>
                <Etudiant nom="test2" prenom="yyy" />
        </div> 
     )}
}

export default Letudiant;
