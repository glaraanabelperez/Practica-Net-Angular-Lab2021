import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
// import { HttpClientModule} from '@angular/common/http';
// import { CommonModule } from '@angular/common';

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
    // HttpClientModule,
    // CommonModule
  ],

  providers: [],
  // HttpClientModule
  bootstrap: [AppComponent]

})
export class AppModule { }
