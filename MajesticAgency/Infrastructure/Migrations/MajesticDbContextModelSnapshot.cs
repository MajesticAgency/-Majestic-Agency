﻿// <auto-generated />
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(MajesticDbContext))]
    partial class MajesticDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Entities.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BackgroundDetail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BackgroundDetail = "/assets/img/portfolio/ServiceDetail1.png",
                            Logo = "/assets/img/ServiceIcon1.png",
                            LongDescription = "We enable you to define your corporate identity by designing or developing your brand from stunning logos and warranties to core values and everything in between, investing in building a brand is how you prepare to connect with your target audience, we also cover a full range of branding services for business and projects of all sizes. Our dedicated team provides you with plans, guidelines, and research that are in line with the market and fit the core of your brand that your concept needs to communicate with. We also show you and your team how to maintain your brand design as it is an important part of all areas of your business.",
                            Name = "Brand & Design Services",
                            ShortDescription = "Your brand is the face of your business. Includes all the many elements that define your corporate identity."
                        },
                        new
                        {
                            Id = 2,
                            BackgroundDetail = "/assets/img/portfolio/ServiceDetail2.png",
                            Logo = "/assets/img/ServiceIcon2.png",
                            LongDescription = "Digital marketing is by far the leading way to get your brand voice out there, gain exposure, and build a strong and loyal relationship with your customers. Creating and maintaining your presence on the digital environment with the right conversation, engaging content and creative design. We will help your brand shine and stay on top. The digital environment has captured the lives of most people out there. We not only do we increase your numbers, but we also aim to deliver substantial content closely related to your brand identity. Our professional team develops a high-quality marketing plan With strategic planning and our consulting expertise, we give life to your presence in the digital environment.",
                            Name = "Digital Marketing Services",
                            ShortDescription = "Digital marketing is the future. Therefore, we are building a complete and integrated digital environment."
                        },
                        new
                        {
                            Id = 3,
                            BackgroundDetail = "/assets/img/portfolio/ServiceDetail3.png",
                            Logo = "/assets/img/ServiceIcon3.png",
                            LongDescription = "We understand the importance of taking your brand to the digital front and making sure it's ready for today's audiences so we bring you the latest web and mobile apps solutions that will help you shine in the digital environment. Our team can help you craft a stylish web or app design that fits your brand as we cover the full range of web and app design and development services, from creating a simple CMS, all the way to web and app maintenance.",
                            Name = "Development Services",
                            ShortDescription = "Your website is the digital face of your brand on the Internet, and your app is your brand in the palm of the user's hand."
                        },
                        new
                        {
                            Id = 4,
                            BackgroundDetail = "/assets/img/portfolio/ServiceDetail4.png",
                            Logo = "/assets/img/ServiceIcon4.png",
                            LongDescription = "We offer you our wealth of experience, creative classiness and technical competence By highlighting your message and putting you first with our customized production services. Helping our clients succeed more through digital content films to animated shorts to high quality photos by captivating audiences, inspiring action & driving results. We constantly aim for true excellence on every project. It’s not about what we do, it’s about how we do it. We handle entire project from planning, excellent communication with everyone the final project execution with pride.",
                            Name = "Production Services",
                            ShortDescription = "Our philosophy in production is our common language by helping our clients achieve more success and progress."
                        },
                        new
                        {
                            Id = 5,
                            BackgroundDetail = "/assets/img/portfolio/ServiceDetail5.png",
                            Logo = "/assets/img/ServiceIcon5.png",
                            LongDescription = "We make content creation simple valuable, relevant, consistent and flexible, dependable content solutions to your needs, whatever industry you're in, to attract and retain your target audience. We provide everything from all types of content for blogs, landing pages, articles and websites to social media, newsletters, emails, videos, texts and more.",
                            Name = "Content Services",
                            ShortDescription = "We provide all sorts of content by creating bold, clear, simple and error-free writing to meet your unique needs."
                        },
                        new
                        {
                            Id = 6,
                            BackgroundDetail = "/assets/img/portfolio/ServiceDetail6.png",
                            Logo = "/assets/img/ServiceIcon6.png",
                            LongDescription = "Language is the method of communication, as we offer you the ability to communicate with the whole world through language translation of videos, social media, the web and a lot.",
                            Name = "Translation Services",
                            ShortDescription = "Ability to communicate with a global audience through a professional linguist."
                        });
                });

            modelBuilder.Entity("Core.Entities.SubService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ServiceId");

                    b.ToTable("SubServices");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Branding & Identity Design",
                            ServiceId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Rebranding & Identity Design",
                            ServiceId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Stationery Design & Production",
                            ServiceId = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "Product & Packaging Design",
                            ServiceId = 1
                        },
                        new
                        {
                            Id = 5,
                            Name = "Advertising Design",
                            ServiceId = 1
                        },
                        new
                        {
                            Id = 6,
                            Name = "Publication Design",
                            ServiceId = 1
                        },
                        new
                        {
                            Id = 7,
                            Name = "Characters & Mascots Design",
                            ServiceId = 1
                        },
                        new
                        {
                            Id = 8,
                            Name = "Digital Marketing Management",
                            ServiceId = 2
                        },
                        new
                        {
                            Id = 9,
                            Name = "Digital Marketing Strategy & Planning",
                            ServiceId = 2
                        },
                        new
                        {
                            Id = 10,
                            Name = "Search Engine Optimisation (SEO)",
                            ServiceId = 2
                        },
                        new
                        {
                            Id = 11,
                            Name = "Google Ads & Analytics",
                            ServiceId = 2
                        },
                        new
                        {
                            Id = 12,
                            Name = "Website & App Marketing",
                            ServiceId = 2
                        },
                        new
                        {
                            Id = 13,
                            Name = "Social Media Marketing",
                            ServiceId = 2
                        },
                        new
                        {
                            Id = 14,
                            Name = "Content Marketing",
                            ServiceId = 2
                        },
                        new
                        {
                            Id = 15,
                            Name = "Automation & Email Marketing",
                            ServiceId = 2
                        },
                        new
                        {
                            Id = 16,
                            Name = "Online Event Marketing",
                            ServiceId = 2
                        },
                        new
                        {
                            Id = 17,
                            Name = "Paid Media",
                            ServiceId = 2
                        },
                        new
                        {
                            Id = 18,
                            Name = "Web Strategy",
                            ServiceId = 3
                        },
                        new
                        {
                            Id = 19,
                            Name = "Website Design & Development",
                            ServiceId = 3
                        },
                        new
                        {
                            Id = 20,
                            Name = "Website Maintenance",
                            ServiceId = 3
                        },
                        new
                        {
                            Id = 21,
                            Name = "E-Commerce Website",
                            ServiceId = 3
                        },
                        new
                        {
                            Id = 22,
                            Name = "Government Website Services",
                            ServiceId = 3
                        },
                        new
                        {
                            Id = 23,
                            Name = "App Strategy",
                            ServiceId = 3
                        },
                        new
                        {
                            Id = 24,
                            Name = "App Design & Development",
                            ServiceId = 3
                        },
                        new
                        {
                            Id = 25,
                            Name = "App Maintenance",
                            ServiceId = 3
                        },
                        new
                        {
                            Id = 26,
                            Name = "E-Commerce App",
                            ServiceId = 3
                        },
                        new
                        {
                            Id = 27,
                            Name = "Government App Services",
                            ServiceId = 3
                        },
                        new
                        {
                            Id = 28,
                            Name = "Video Production Services",
                            ServiceId = 4
                        },
                        new
                        {
                            Id = 29,
                            Name = "Corporate Video Production",
                            ServiceId = 4
                        },
                        new
                        {
                            Id = 30,
                            Name = "Animation Videos",
                            ServiceId = 4
                        },
                        new
                        {
                            Id = 31,
                            Name = "Digital Media Videos",
                            ServiceId = 4
                        },
                        new
                        {
                            Id = 32,
                            Name = "Promotional & Commercials Videos",
                            ServiceId = 4
                        },
                        new
                        {
                            Id = 33,
                            Name = "Video Editing Services",
                            ServiceId = 4
                        },
                        new
                        {
                            Id = 34,
                            Name = "Event Coverage",
                            ServiceId = 4
                        },
                        new
                        {
                            Id = 35,
                            Name = "Screen Writing",
                            ServiceId = 4
                        },
                        new
                        {
                            Id = 36,
                            Name = "Photography",
                            ServiceId = 4
                        },
                        new
                        {
                            Id = 37,
                            Name = "Content Writing",
                            ServiceId = 5
                        },
                        new
                        {
                            Id = 38,
                            Name = "Copywriting",
                            ServiceId = 5
                        },
                        new
                        {
                            Id = 39,
                            Name = "Speech Writing",
                            ServiceId = 5
                        },
                        new
                        {
                            Id = 40,
                            Name = "Editing & Proofreading",
                            ServiceId = 5
                        },
                        new
                        {
                            Id = 41,
                            Name = "Media Translation",
                            ServiceId = 6
                        },
                        new
                        {
                            Id = 42,
                            Name = "Business Translation",
                            ServiceId = 6
                        },
                        new
                        {
                            Id = 43,
                            Name = "Financial Translation",
                            ServiceId = 6
                        },
                        new
                        {
                            Id = 44,
                            Name = "Technical Translations",
                            ServiceId = 6
                        },
                        new
                        {
                            Id = 45,
                            Name = "Website Content Translation",
                            ServiceId = 6
                        });
                });

            modelBuilder.Entity("Core.Entities.SubService", b =>
                {
                    b.HasOne("Core.Entities.Service", "Service")
                        .WithMany("subServices")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Service");
                });

            modelBuilder.Entity("Core.Entities.Service", b =>
                {
                    b.Navigation("subServices");
                });
#pragma warning restore 612, 618
        }
    }
}
