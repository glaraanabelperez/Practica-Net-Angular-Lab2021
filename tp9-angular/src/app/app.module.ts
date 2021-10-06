import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { AppCustomersModule } from './northwind/customers/app.customers-module';



@NgModule({
  declarations: [
    AppComponent
  ],

  imports: [
    BrowserModule,
    AppRoutingModule,
    AppCustomersModule,
  ],

  providers: [],

  bootstrap: [AppComponent]

})
export class AppModule { }
