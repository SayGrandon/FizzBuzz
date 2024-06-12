import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { FizzbuzzCalcComponent } from './components/fizzbuzz-calc/fizzbuzz-calc.component';

@NgModule({
  declarations: [
    AppComponent,
    FizzbuzzCalcComponent
  ],
  imports: [
    BrowserModule, HttpClientModule, FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
