import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";

import { ResourceNotFoundComponent } from "./resource-not-found.component";

@NgModule({
  declarations: [
      ResourceNotFoundComponent,
  ],
  imports: [
      BrowserModule,
  ],
})
export class CoreComponentsModule { }
