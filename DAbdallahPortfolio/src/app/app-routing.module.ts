import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { AboutMeComponent } from './pages/about-me/about-me.component';
import { MyProjectsComponent } from './pages/my-projects/my-projects.component';


const routes: Routes = [
  {path: 'home', component: HomeComponent},
  {path: 'about-me', component: AboutMeComponent},
  {path: 'my-projects', component: MyProjectsComponent},
  {
    path: '',
    redirectTo:'/home',
    pathMatch: 'full'},
  {path:'**', component: HomeComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
