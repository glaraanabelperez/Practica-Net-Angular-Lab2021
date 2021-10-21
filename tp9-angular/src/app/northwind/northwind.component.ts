import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-northwind',
  templateUrl: './northwind.component.html',
  styleUrls: ['./northwind.component.sass']
})
export class AppComponentNorthwind{

  constructor(public router:Router) { 
  }

  ngOnInit(): void {    
  }


}
