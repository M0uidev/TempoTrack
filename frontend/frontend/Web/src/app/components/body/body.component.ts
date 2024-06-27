import { Component } from '@angular/core';
const axios = require('axios');

@Component({
  selector: 'app-body',
  templateUrl: './body.component.html',
  styleUrls: ['./body.component.css']
})
export class BodyComponent {
    estaciones: string[] = [];
    mediciones: any[] = [];
    fallas: number = 0;
    normales: number = 0;

    constructor(){
      this.getMediciones()
      this.getEstaciones()
    }


    getEstaciones(){
      let config = {
        method: 'get',
        maxBodyLength: Infinity,
        url: 'https://localhost:7039/Estaciones/index',
        headers: { }
      };
      
      axios.request(config)
      .then((response: { data: any; }) => {
        this.estaciones = response.data;
      })
      .catch((error: any) => {
        console.log(error);
      });
    }

    async getMediciones(){
      let config = {
        method: 'get',
        maxBodyLength: Infinity,
        url: 'https://localhost:7039/',
        headers: { }
      };
      
      axios.request(config)
      .then((response: { data: any; }) => {
        this.mediciones = response.data;
        console.log(this.mediciones)
        this.fallas = this.mediciones.filter(x => x.Estado == false).length
        this.normales = this.mediciones.filter(x => x.Estado == true).length
      })
      .catch((error: any) => {
        console.log(error);
      });      
    }
}


