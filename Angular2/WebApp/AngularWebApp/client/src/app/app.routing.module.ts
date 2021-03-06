﻿import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";

import { ResourceNotFoundComponent } from "./core/components/resource-not-found.component";

const appRoutes: Routes = [
  { path: "", redirectTo: "/a", pathMatch: "full" },
  { path: "**", component: ResourceNotFoundComponent }
];

@NgModule({
  imports: [
      RouterModule.forRoot(
          appRoutes,
          { enableTracing: true }
      )
  ]
})
export class AppRoutingModule { }
