import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";
import { RouterModule } from "@angular/router"

import { ResourceNotFoundComponent } from "./resource-not-found.component";
import { TopMenuComponent } from "./topmenu.component";

@NgModule({
    declarations: [
        ResourceNotFoundComponent,
        TopMenuComponent
    ],
    exports: [
        TopMenuComponent,
        ResourceNotFoundComponent
    ],
    imports: [
        BrowserModule,
        RouterModule
    ],
})
export class CoreComponentsModule { }
