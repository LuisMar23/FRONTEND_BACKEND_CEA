import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
// import { CookieService } from 'ngx-cookie-service';
import { AccesoModule } from './modules/acceso/acceso.module';

import { HomeModule } from './modules/home/home.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { SingInModule } from './modules/singin/singin.module';



@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    AccesoModule,
    HomeModule,
    BrowserAnimationsModule,
    SingInModule
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
