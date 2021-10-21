import { Component, OnInit } from '@angular/core';
import { Morty } from './models/morty';
import { ServiceMorty } from './services/morty.service';

@Component({
  selector: 'app-Morty',
  templateUrl: './morty.component.html',
  styleUrls: ['./morty.component.scss']
})
export class AppComponentMorty  {

  characters: Array<Morty>=[];

  constructor(private _serviceMorty: ServiceMorty){
    this.getAllCharacters();

  }

  getAllCharacters(){
    this._serviceMorty.getAll().subscribe(
      res=>{
        if(res!=null){
          this.characters=res;
        }
      },
      err => {
        alert("Oops!!, Hubo un error para traer los datos")
      })
  }


}
