import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PageNotFoundComponent } from './app-common/page-not-found/page-not-found.component';
import { DashbordComponent } from './app-common/dashbord/dashbord.component';
import { DomainAComponent } from './domain-a/domain-a.component';

let routes: Routes = [
  { path: 'domain-a', component: DomainAComponent },
  { path: '', component: DashbordComponent, pathMatch: 'full' },
  { path: '**', component: PageNotFoundComponent }
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes)
  ],
  declarations: [],
  exports: [RouterModule]
})
export class AppRoutingModule { }
