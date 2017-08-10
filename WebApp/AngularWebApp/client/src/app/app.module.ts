import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router'

import { AppComponent } from './app.component';
import { Module as AModule} from './moduleA/module';
import { Module as BModule } from './moduleB/module';

import { ContainerComponent as AComponent } from './moduleA/components/container.component'
import { ContainerComponent as BComponent } from './moduleB/components/container.component'


const appRoutes: Routes = [
    { path: 'a', component: AComponent },
    { path: 'b', component: BComponent }, // <-- delete this line
    { path: '', redirectTo: '/a', pathMatch: 'full' }
];

@NgModule({
  declarations: [
      AppComponent,
  ],
  imports: [
      BrowserModule,
      RouterModule.forRoot(
          appRoutes,
          { enableTracing: true }
      ),

      AModule,
      BModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
