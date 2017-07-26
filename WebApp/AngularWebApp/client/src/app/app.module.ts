import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { PosModule } from './pos/pos.module';

import { AppComponent } from './app.component';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
      BrowserModule,
      PosModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
