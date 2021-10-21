import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'home-northwind',
  templateUrl: './home-northwind.component.html',
  styleUrls: ['./home-northwind.component.sass']
})
export class HomeNorthwind{

  show:boolean;

  constructor(public router:Router) { 
  }

  ngOnInit(): void {
    this.show=true;
    
  }

  ngOnChanges(){
    if(this.router.url==="/northwind"){
      this.show=true;
    }
  }

  notShow(){
    this.show=false;
  }
  
}
