import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HomeComponent } from './home/home.component';
import { SkiLengthCalculatorComponent } from './ski-length-calculator/ski-length-calculator.component';
import { HttpClientModule } from '@angular/common/http';
import { MaterialModule } from './materials';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    SkiLengthCalculatorComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    MaterialModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
