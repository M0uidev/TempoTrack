import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { AboutComponent } from './components/about/about.component';
import { ReportesComponent } from './components/reportes/reportes.component';

const routes: Routes = [
  {
    path:"", component: HomeComponent
  },
  {
    path:"home", component: HomeComponent
  },
  {
    path:"about", component: AboutComponent
  },
  {
    path:"reportes", component: ReportesComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
