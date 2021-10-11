import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.sass']
})
export class HeaderComponent implements OnInit {

  apiNortShow:boolean;

  constructor() { 
    this.apiNortShow=true;
  }

  ngOnInit(): void {
  }
 
  showApiNort(){
    console.log(this.apiNortShow)
    this.apiNortShow=true;
  }

  showApiMorty(){
    console.log(this.apiNortShow)
    this.apiNortShow=false;
  }


}
