import { Component, OnInit } from '@angular/core';
import { Morty } from './models/Morty';
import { ServiceMorty } from './services/service_morty.service';

@Component({
  selector: 'app-Morty',
  templateUrl: './app.componentMorty.html',
  styleUrls: ['./app.componentMorty.scss']
})
export class AppComponentMorty  {

  characters: Array<Morty>=[];

  constructor(private _serviceMorty: ServiceMorty){
    this.GetAllCharacters();

  }

  GetAllCharacters(){
    this._serviceMorty.GetAll().subscribe(res=>{
      this.characters=res;
      console.log(res);
    })
  }


}
