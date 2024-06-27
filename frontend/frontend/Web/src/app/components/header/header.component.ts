import { Component } from '@angular/core';
const axios = require('axios');

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent {
  step:string = ""
  
  generar(){
    let config = {
      method: 'post',
      maxBodyLength: Infinity,
      url: 'https://localhost:7039/home/Create/',
      headers: { }
    };
    
    axios.request(config)
    .then((response: { data: any; }) => {
      console.log(JSON.stringify(response.data));
      window.location.reload();
    })
    .catch((error: any) => {
      console.log(error);
    });
  }
}
