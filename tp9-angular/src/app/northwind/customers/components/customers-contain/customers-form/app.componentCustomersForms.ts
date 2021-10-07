import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';


@Component({
  selector: 'app-component-customers-forms',
  templateUrl: './app.componentCustomersForms.html',
  styleUrls: ['./app.componentCustomersForms.sass']
})

export class AppComponentCustomersForms {

  uploadForm: FormGroup;
  actionBtnFormEditar: boolean=true;

  constructor( private formBuilder:FormBuilder){

    this.uploadForm=this.formBuilder.group({
      // id:[null],
      companyName:['', [Validators.required]],
      contactName:['', [Validators.required]],
      country:['', [Validators.required]]

    })

  }

  // ngOnInit(): void {

  //   throw new Error('Method not implemented.');
  // }
  
  get f(){ return this.uploadForm.controls;}

  submitted=false;
  onSubmit():void{
    this.submitted=true;
    if(this.uploadForm.invalid){
      return;
    }else{
      if(this.actionBtnFormEditar){
        return;
      }else{
        return;
      }
      
    }

  }
}
